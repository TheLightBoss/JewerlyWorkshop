const { json } = require('express');
const db = require('../connection_db/db')
class ProceduresController{

    async createProduction(req, res){
        const {id_prod, id_empl} = req.body;
        console.log("Requested method POST 'Production'");
        try{
            await db.query('CALL public.insert_production($1, $2);', [id_prod, id_empl]);
            res.json(0);
        }
        catch{
            res.json(-1);
        }
    }

    async updateProduction(req, res){
        const {id_production, list_done, status, half_status} = req.body;
        console.log("Requested method PUT 'Production'");
        //try-catch работает некорректно ИСПРАВИТЬ
        try{
            const result = await db.
            query('CALL public.update_production($1, $2, $3, $4);', 
            [id_production, list_done, status, half_status]);
            res.json(0);
        }
        catch{
            res.json(-1);
        }
    }
    
    async createEmployee(req, res){
        const {fio_new, address_new, passp, exp, log, passw} = req.body;
        const employees = await db.query('SELECT id_empl, login, password  FROM public.employees;');
        const copyEmpl = employees.rows.find(row => row['login'] === log && row['password'] === passw);
        console.log("Requested method POST 'Employee'");
        try{
            if(copyEmpl !== undefined){
                throw new Error;
            }
            await db.query('CALL public.insert_employee($1, $2, $3, $4, $5, $6);', 
            [fio_new, address_new, passp, exp, log, passw]);
            res.json(0);
        }
        catch{
            res.json("Login and password are not special");
        }
    }

    async updateEmployee(req, res){
        const {idd, fio_new, address_new, passp, exp, log, passw} = req.body;
        const employees = await db.query('SELECT id_empl, login, password FROM public.employees;');
        const copyEmpl = employees.rows.find(row => row['login'] === log 
            && row['password'] === passw);
        console.log("Requested method PUT 'Employee'");
        try{
            if(copyEmpl === undefined || copyEmpl['id_empl'] === idd ){
                await db.query('CALL public.update_employee($1, $2, $3, $4, $5, $6, $7);', 
                [idd, fio_new, address_new, passp, exp, log, passw]);
                res.json(0);                
            }
            else{
                throw new Error;
            }
        }
        catch{
            res.json(-1);
        }
    }
    
    async createReferenceProduct(req, res){
        
    }

    async updateReferenceProduct(req, res){
        
    }

}

//экспортируем объект этого контроллера
module.exports = new ProceduresController()