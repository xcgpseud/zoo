using Microsoft.AspNetCore.Mvc;
using Domain.DataModels.Zoo;

namespace Zoo.Controllers.Zoo;

[Route("[controller]")]
public class ZooController : Controller
{
    private List<ZooModel> _zoos = new();

    [HttpPost]
    public IActionResult Create([FromBody] ZooModel zooModel)
    {
        zooModel.Guid = Guid.NewGuid();
        _zoos.Add(zooModel);

        return Ok(zooModel);
    }

    [HttpGet]
    public List<ZooModel> GetAll()
    {
        return _zoos;
    }
}