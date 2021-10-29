const db = require('../connection_db/db')

class ViewsController{
    /*
    * Получение заказов для менеджерского приложения
    */
   //метод получился сложным позже ИЗМЕНИТЬ 
    async getOrders(req, res){
        const {argument} = req.body;
        console.log("Requested method GET 'Orders' " + argument);
        const all_orders = await db.query('SELECT * FROM all_orders');
        if(argument === "new"){
            const result = all_orders.rows.filter(row => row['id_empl'] === null);
            res.json(result);
        }
        else if(argument === "run"){
            const result = all_orders.rows.filter(row => row['id_empl'] !== null);
            res.json(result);
        }
        else{
            res.json(all_orders.rows);
        }
    }
    /*
    * Получение заказов для клиентского приложения
    */
    async getClientOrders(req, res){
        const {id} = req.body;
        console.log("Requested method GET 'ClientOrders' id_client = " + id);
        const client_orders = await db.query('SELECT * FROM client_orders');
        const result = client_orders.rows.filter(row => row['id_client'] == id);
        res.json(result);
    }
}

//экспортируем объект этого контроллера
module.exports = new ViewsController()