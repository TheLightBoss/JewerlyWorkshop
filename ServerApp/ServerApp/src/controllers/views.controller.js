const db = require('../connection_db/db')

class ViewsController{
    /** 
     * Getting orders for managment's app.
     * if argument : new - to get new orders
     * if argument : run - to get running orders
     * else  
    */
    async getOrders(req, res){
        const {argument} = req.body;
        console.log("Requested method POST 'Orders' " + argument);
        const all_orders = await db.query('SELECT * FROM all_orders');
        if(argument === "new"){
            const result = all_orders.rows.filter(row => row['id_empl'] === null);
            console.log("Request time: " + new Date);
            res.json(result);
        }
        else if(argument === "run"){
            const result = all_orders.rows.filter(row => row['id_empl'] !== null
            && row['status'] !== true);
            console.log("Request time: " + new Date);
            res.json(result);
        }
        else{
            const result = all_orders.rows.filter(row => row['status'] === true);
            console.log("Request time: " + new Date);
            res.json(result);
        }
    }
    /**
     * Getting orders for client's app.
    */
    async getClientOrders(req, res){
        const {id} = req.body;
        console.log("Requested method POST 'Client's orders' id_client = " + id);
        const client_orders = await db.query('SELECT * FROM client_orders');
        const result = client_orders.rows.filter(row => row['id_client'] == id);
        console.log("Request time: " + new Date);
        res.json(result);
    }
    async getEmployee(req, res){
        console.log(req.body);
        const {login, password} = req.body;
        console.log("Requested method GET 'Authorization'" + [login, password]);
        const client_orders = await db.query('SELECT * FROM employees');
        const result = client_orders.rows.find(row => 
            row['login'] === login && row['password'] === password);
        if(result === undefined){
            console.log("'Authorization' undefined");
            console.log("Request time: " + new Date);
            res.json(-1);
        }
        else{
            console.log("'Authorization' id_empl = " + result['id_empl']);
            console.log("Request time: " + new Date);
            res.json(result);
        }
        
    }
}

//export this object
module.exports = new ViewsController()