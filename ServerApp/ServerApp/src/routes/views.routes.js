const Router = require('express');

const router = new Router();

const viewsController = require("../controllers/views.controller");

router.post('/orders', viewsController.getOrders);
router.post('/client', viewsController.getClientOrders);
router.post('/employee', viewsController.getEmployee);

module.exports = router