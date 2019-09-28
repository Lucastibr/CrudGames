using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudGames.Models
{

    //Aqui criamos o DB Context com o nome de GameContext
    public class GameContext:DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {
        }

        //Aqui setamos o DBSET e passamos a classe game e o parametro GAMES!
        public DbSet<Game> Games { get; set; }
    }

    public class Game
    {

        //Key é a ID
        [Key]
        public int GameId { get; set; }

        //Aqui passamos as colunas e valores para ser armazenados no BD
        //Com o nome do jogo, preco e categoria!
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage ="Esse campo é obrigatório")]
        [DisplayName("Nome do Jogo")]
        public string NomeDoJogo { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [DisplayName("Preço do Jogo")]
        public int PrecoDoJogo { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [DisplayName("Categoria do Jogo")]
        public string Categoria { get; set; }

    }



}

