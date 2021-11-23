const { json } = require('express');
const db = require('../connection_db/db')
class ProceduresController{

    /**
     * Adding an entry to the 'productions' 
     */
    async createProduction(req, res){
        const {id_empl, id_prod} = req.body;
        console.log("Requested method POST 'Production'");
        try{
            await db.query('CALL public.insert_production($1, $2);', [id_empl, id_prod]);
            console.log("Added an entry to the 'productions'");
            console.log("Request time: " + new Date);
            res.json(0);
        }
        catch(e){
            console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
            console.log("Request time: " + new Date);
            res.json(-1);
        }
    }
    /**
     * Updating an entry to the 'productions'
     */
    async updateProduction(req, res){
        const {id_production, list_done, status, half_status} = req.body;
        console.log("Requested method PUT 'Production'");
        try{
            const result = await db.
            query('CALL public.update_production($1, $2, $3, $4);', 
            [id_production, list_done, status, half_status]);
            console.log("Updated an entry to the 'productions' (id = " + id_production + ")");
            console.log("Request time: " + new Date);
            res.json(0);
        }
        catch(e){
            console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
            console.log("Request time: " + new Date);
            res.json(-1);
        }
    }
    /**
     * Adding an entry to the 'employees' 
     */
    async createEmployee(req, res){
        const {fio_new, address_new, passp, exp, log, passw} = req.body;
        const employees = await db.query('SELECT id_empl, login, password  FROM public.employees;');
        const copyEmpl = employees.rows.find(row => row['login'] === log && row['password'] === passw);
        console.log("Requested method POST 'Employee'");
        try{
            if(copyEmpl !== undefined){
                throw new Error('Login and password are not special');
            }
            await db.query('CALL public.insert_employee($1, $2, $3, $4, $5, $6);', 
            [fio_new, address_new, passp, exp, log, passw]);
            console.log("Added an entry to the 'employees'");
            console.log("Request time: " + new Date);
            res.json(0);
        }
        catch(e){
            console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
            console.log("Request time: " + new Date);
            res.json(-1);
        }
    }
    /**
     * Updating an entry to the 'employees'
     */
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
                console.log("Updated an entry to the 'employees' (id = " + idd + ")");
                console.log("Request time: " + new Date);
                res.json(0);                
            }
            else{
                throw new Error('Login and password are not special');
            }
        }
        catch(e){
            console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
            console.log("Request time: " + new Date);
            res.json(-1);
        }
    }
    /**
     * Adding an entry to the 'reference_products' 
     */
    async createReferenceProduct(req, res){
        const {name_pr, url, id_mat, name_it, id_dec, id_listt, weight} = req.body;
        console.log("Requested method POST 'Reference Product'");
        try{
            await db.query('CALL public.insert_ref_product($1, $2, $3, $4, $5, $6, $7);', 
            [name_pr, url, id_mat, name_it, id_dec, id_listt, weight]);
            console.log("Added an entry to the 'reference_products'");
            console.log("Request time: " + new Date);
            res.json(0);
        }
        catch(e){
            console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
            console.log("Request time: " + new Date);
            res.json(-1);
        }
    }
    /**
     * Updating an entry to the 'reference_products'
     */
    async updateReferenceProduct(req, res){
        const {idd, name_pr, url, id_mat, name_it, id_dec, id_listt, weight} = req.body;
        console.log("Requested method PUT 'Reference Product'");
        try{
            await db.query('CALL public.update_ref_product($1, $2, $3, $4, $5, $6, $7, $8);', 
            [idd, name_pr, url, id_mat, name_it, id_dec, id_listt, weight]);
            console.log("Updated an entry to the 'reference_products'");
            console.log("Request time: " + new Date);
            res.json(0);
        }
        catch(e){
            console.log('Error ' + e.name + ":" + e.message + "\n" + e.stack);
            console.log("Request time: " + new Date);
            res.json(-1);
        }
    }
}

//export this object
module.exports = new ProceduresController()