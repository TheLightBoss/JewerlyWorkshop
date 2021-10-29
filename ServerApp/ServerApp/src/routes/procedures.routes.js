const Router = require('express');
const proceduresController = require('../controllers/procedures.controller');

const router = new Router();

router.post('/production/', proceduresController.createProduction);
router.put('/production/', proceduresController.updateProduction);
router.post('/employee/', proceduresController.createEmployee);
router.put('/employee/', proceduresController.updateEmployee);
router.post('/ref_product/', proceduresController.createReferenceProduct);
router.put('/ref_product/', proceduresController.updateReferenceProduct);

module.exports = router