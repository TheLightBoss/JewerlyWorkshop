const db = require('../connection_db/db');
var service_orders = {
    Orders_Service: {
        Orders_Port: {
            getOrders: async function (args) {
                console.log(args.value_json);
                const { id } = JSON.parse(args.value_json);
                console.log("\nRequested method POST 'Client's orders' id_client = " + id);
                const client_orders = await db.query('SELECT * FROM client_orders WHERE id_client = ' + id);
                console.log("Request time: " + new Date);
                return { bmi: JSON.stringify(client_orders.rows) };
            },
            createOrder: async function (args) {
                const { id_ref_prod, id_client, price_prod, size, weight } = JSON.parse(args.value_json);
                console.log("\nRequested method(insert) POST 'Orders' (& 'Products')");
                try {
                    await db.query('CALL public.insert_order($1, $2, $3, $4, $5);',
                        [id_ref_prod, id_client, price_prod, size, weight]);
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
            }
        }
    }
}

module.exports = service_orders;