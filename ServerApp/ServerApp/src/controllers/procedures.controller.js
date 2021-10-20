const db = require('../connection_db/db')
class ProceduresController{

    async createProduction(req, res){
        const {id_prod, id_empl} = req.body;
        const before = await db.query('SELECT COUNT(*) FROM productions;');
        //console.log("before " + before.rows[0]['count']);
        console.log("Requested method POST 'Production'");
        await db.query('CALL public.insert_production($1, $2);', [id_prod, id_empl]);
        const after = await db.query('SELECT COUNT(*) FROM productions;');
        //console.log("after " + after.rows[0]['count']);
        //проверка на добавление
        //при успешном выполнении возвращается 0
        if(before.rows[0]['count'] < after.rows[0]['count']){
            res.json(0);
        }
        else{
            res.json(-1);
        }
    }

    async updateProduction(req, res){
        const {id_production, list_done, status, half_status} = req.body;
        console.log("Requested method PUT 'Production'" + id_production +
         list_done + status + half_status);
        const result = await db.
            query('CALL public.update_production($1, $2, $3, $4);',
            [id_production, list_done, status, half_status]);
        res.json(result.rows);
    }
    
}

//экспортируем объект этого контроллера
module.exports = new ProceduresController()