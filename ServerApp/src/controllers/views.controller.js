const db = require('../connection_db/db');

class ViewsController {
    /** 
     * Getting orders for managment's app.
     * if argument : new - to get new orders
     * if argument : run - to get running orders
     * else  
    */
    async getOrders(req, res) {
        const { argument } = req.body;
        console.log("\nRequested method POST 'Orders' " + argument);
        
        if (argument === "new") {
            const result = await db.query('SELECT * FROM new_orders');
            console.log("Count orders: " + result.rows.length);
            console.log("Request time: " + new Date);
            res.json(result.rows);
        }
        else if (argument === "run") {
            const result = await db.query('SELECT * FROM run_orders');
            console.log("Count orders: " + result.rows.length);
            console.log("Request time: " + new Date);
            res.json(result.rows);
        }
        else {
            console.log("Request time: " + new Date);
            res.json("0");
        }
    }
    /**
     * Getting orders for client's app.
    */
    async getClientOrders(req, res) {
        const { id } = req.body;
        console.log("\nRequested method POST 'Client's orders' id_client = " + id);
        const client_orders = await db.query('SELECT * FROM client_orders');
        const rr = client_orders.rows.forEach(el => {
            if(el['status'] == null) 
            {
                console.log(el['status']) 
                el['status'] = false;
            }
        });
        const result = rr.filter(row => row['id_client'] == id);
        console.log("Request time: " + new Date);
        res.json(result);
    }
    /**
     * Getting orders for employee's app.
    */
    async getEmplOrders(req, res) {
        const { id_empl } = req.body;
        console.log("\nRequested method POST 'Employee's orders' id_empl = " + id_empl);
        const client_orders = await db.query('SELECT * FROM empl_orders');
        const result = client_orders.rows.filter(row => row['id_empl'] == id_empl);
        console.log("Count rows: " + result.length);
        console.log("Request time: " + new Date);
        res.json(result);
    }
    async getEmployee(req, res) {
        const { login, password } = req.body;
        console.log("\nRequested method POST 'Authorization'" + [login, password]);
        const client_orders = await db.query('SELECT * FROM employees');
        const result = client_orders.rows.find(row =>
            row['login'] === login && row['password'] === password);
        if (result === undefined) {
            console.log("'Authorization' undefined");
            console.log("Request time: " + new Date);
            res.json(-1);
        }
        else {
            console.log("'Authorization' id_empl = " + result['id_empl']);
            console.log("Request time: " + new Date);
            res.json(result);
        }

    }
    async getEmpls(req, res) {
        console.log("\nRequested method POST 'Employees'");
        const empls = await db.query('SELECT * FROM employees ORDER BY id_empl');
        console.log("Count rows: " + empls.rows.length);
        console.log("Request time: " + new Date);
        res.json(empls.rows);
    }
    
}

//export this object
module.exports = new ViewsController();