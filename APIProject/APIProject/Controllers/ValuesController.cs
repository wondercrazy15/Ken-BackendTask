using APIProject.CutomeModel;
using APIProject.Interface;
using APIProject.Model;
using APIProject.Service;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Controllers;
[Route("api/Values")]
[ApiController]
public class ValuesController : Controller
{

    private IValueService _valueService;


    public ValuesController(IValueService valueService)
    {
        this._valueService = valueService;
    }

    [HttpPost]
    [Route("add")]
    public IActionResult add(StoreValueModel model)
    {
        ValueModel valueModel = new ValueModel();
        try
        {
            if(model != null)
            {
                var storeValueModel = new StoreValues
                {
                    Number1 = model.Number1,
                    Number2 = model.Number2
                };

                _valueService.addValues(storeValueModel);

                valueModel.SumOfValue = model.Number1 + model.Number2;

                return Ok(valueModel);
            }
            else
            {
                return NotFound();
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        
    }
}
