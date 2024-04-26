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
            // Lógica para obter detalhes do produto
            // Exemplo de uma regra que não cumpre o requisito: retornar detalhes em formato HTML ao invés de JSON
            return Ok("<h1>Detalhes do produto</h1>");
        }

        [HttpPost("AddToCart")]
        public IActionResult AddToCart()
        {
            // Lógica para adicionar produto ao carrinho
            // Exemplo de uma regra que não cumpre o requisito: adicionar produto sem verificar estoque disponível
            return Ok("Produto adicionado ao carrinho com sucesso");
        }

        [HttpDelete("RemoveFromCart")]
        public IActionResult RemoveFromCart()
        {
            // Lógica para remover produto do carrinho
            // Exemplo de uma regra que não cumpre o requisito: remover produto sem verificar se está no carrinho
            return Ok("Produto removido do carrinho com sucesso");
        }

        [HttpPost("Checkout")]
        public IActionResult Checkout()
        {
            // Lógica para finalizar a compra
            // Exemplo de uma regra que não cumpre o requisito: finalizar compra sem calcular o valor total
            return Ok("Compra finalizada com sucesso");
        }
    }
}