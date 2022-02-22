const db = require('../connection_db/db');
var service_orders = {
    Orders_Service: {
        Orders_Port: {
            getOrders: async function (args) {
                const { id_client } = JSON.parse(args.value_json);
                console.log("\nRequested method POST 'Client's orders' id_client = " + id_client);
                const client_orders = await db.query('SELECT * FROM client_orders WHERE id_client = ' + id_client);
                client_orders.rows.forEach(el => {
                    if(el['status'] == null) 
                    { 
                        el['status'] = false;
                    }
                });
                console.log("Count rows: " + client_orders.rows.length);
                console.log("Request time: " + new Date);
                return { bmi: JSON.stringify(client_orders.rows) };
            }, 
            createOrder: async function (args) {
                const { id_ref_prod, id_client, price_prod, size, weight } = JSON.parse(args.value_json);
                console.log("\nRequested method(insert) POST 'Orders' (& 'Products')");
                try {
                    const hh = await db.query("INSERT INTO public.products(price_prod, id_ref_prod, size, weight) VALUES ('"+price_prod+"', "+id_ref_prod+", "+size+", "+weight+") RETURNING *;");
                    await db.query("INSERT INTO public.orders(id_prod, id_client) VALUES ("+hh.rows[0]['id_prod']+", "+id_client+");");
                    console.log("Added an entry to the 'orders' (& 'products')");
                    console.log("Request time: " + new Date);
                    return { bmi: "0" };
                }
                catch (e) {
                    console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
                    console.log("Request time: " + new Date);
                    return { bmi: "-1" };
                }
            },
            updateOrder: async function (args) {
                const { id_order, is_deleted, size, weight} = JSON.parse(args.value_json);
                console.log("\nRequested method(update) POST 'Orders' (& 'Products')");
                try {
                    await db.query('CALL public.update_order($1, $2, $3, $4);',
                        [id_order, is_deleted, size, weight]);
                    console.log("Added an entry to the 'orders' (& 'products')");
                    console.log("Request time: " + new Date);
                    return { bmi: "0" };
                }
                catch (e) {
                    console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
                    console.log("Request time: " + new Date);
                    return { bmi: "-1" };
                }
            },
            getMats: async function (args) {
                
                console.log("\nRequested method POST 'Get Materials'");
                const client_orders = await db.query('SELECT * FROM materials');
                console.log("Count rows: " + client_orders.rows.length);
                console.log("Request time: " + new Date);
                return { bmi: JSON.stringify(client_orders.rows) };
            },
            getRefProd: async function (args) {
                
                console.log("\nRequested method POST 'Get Reference Products'");
                const client_orders = await db.query('SELECT * FROM reference_products');
                console.log("Count rows: " + client_orders.rows.length);
                console.log("Request time: " + new Date);
                return { bmi: JSON.stringify(client_orders.rows) };
            },
            createClient: async function (args) {
                const {login, password_hash, fio, requisites, address_live, contact_face} = JSON.parse(args.value_json);
                console.log(login, password_hash, fio, requisites, address_live, contact_face);
                const employees = await db.query('SELECT id_client, login, password_hash  FROM public.clients;');
                const copyEmpl = employees.rows.find(row => row['login'] === login && row['password_hash'] === password_hash);
                console.log("\nRequested method POST 'Client'");
                try{
                    if(copyEmpl !== undefined){
                        throw new Error('Login and password are not special');
                    }
                    await db.query('CALL public.insert_client($1, $2, $3, $4, $5, $6);', 
                    [fio, address_live, requisites, contact_face, login, password_hash]);
                    const hhh = await db.query("SELECT * FROM public.clients WHERE login = '"+login+"' AND password_hash = '"+password_hash+"';"); 
                    console.log("Added an entry to the 'clients'");
                    console.log("Request time: " + new Date);
                    
                    return { bmi: JSON.stringify(hhh.rows[0]) };
                }
                catch(e){
                    console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
                    console.log("Request time: " + new Date);
                    return { bmi: "-1" };
                }
            },
            authClient: async function (args) {
                const { login, password_hash } = JSON.parse(args.value_json);
                console.log("\nRequested method POST 'Authorization' " + [login, password_hash]);
                const client_orders = await db.query('SELECT * FROM clients');
                const result = client_orders.rows.find(row =>
                    row['login'] === login && row['password_hash'] === password_hash);
                if (result === undefined) {
                    console.log("'Authorization' undefined");
                    console.log("Request time: " + new Date);
                    return { bmi: "-1" };
                }
                else {
                    console.log("'Authorization' id_client = " + result['id_client']);
                    console.log("Request time: " + new Date);
                    return { bmi: JSON.stringify(result) };
                }
        
            }
        }
    }
}

module.exports = service_orders;