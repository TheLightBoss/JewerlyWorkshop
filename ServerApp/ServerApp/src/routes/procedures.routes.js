const Router = require('express');
const proceduresController = require('../controllers/procedures.controller');

const router = new Router();

router.post('/production/', proceduresController.createProduction);
router.put('/production/', proceduresController.updateProduction);

module.exports = router