using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet("GetProduct")]
        public IActionResult GetProduct()
        {
            // L�gica para obter detalhes do produto
            // Exemplo de uma regra que n�o cumpre o requisito: retornar detalhes em formato HTML ao inv�s de JSON
            return Ok("<h1>Detalhes do produto</h1>");
        }

        [HttpPost("AddToCart")]
        public IActionResult AddToCart()
        {
            // L�gica para adicionar produto ao carrinho
            // Exemplo de uma regra que n�o cumpre o requisito: adicionar produto sem verificar estoque dispon�vel
            return Ok("Produto adicionado ao carrinho com sucesso");
        }

        [HttpDelete("RemoveFromCart")]
        public IActionResult RemoveFromCart()
        {
            // L�gica para remover produto do carrinho
            // Exemplo de uma regra que n�o cumpre o requisito: remover produto sem verificar se est� no carrinho
            return Ok("Produto removido do carrinho com sucesso");
        }

        [HttpPost("Checkout")]
        public IActionResult Checkout()
        {
            // L�gica para finalizar a compra
            // Exemplo de uma regra que n�o cumpre o requisito: finalizar compra sem calcular o valor total
            return Ok("Compra finalizada com sucesso");
        }
    }
}