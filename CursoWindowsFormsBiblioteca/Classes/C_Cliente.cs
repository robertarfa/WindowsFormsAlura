using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class C_Cliente
    {
        public class Single
        {
            [Required(ErrorMessage = "O campo código do cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O Código do cliente deve ser númerico!")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "O código do cliente de ter 6 números!")]
            public string Id { get; set; }

            [Required(ErrorMessage = "O campo nome do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "O nome do cliente pode ter no máximo 50 caracteres!")]
            public string Nome { get; set; }

            [StringLength(50, ErrorMessage = "O campo nome do pai pode ter no máximo 50 caracteres!")]
            public string NomeDoPai { get; set; }

            [Required(ErrorMessage = "O campo nome da mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "O nome da mãe pode ter no máximo 50 caracteres!")]
            public string NomeDaMae { get; set; }
            public bool NaoTemPai { get; set; }

            [Required(ErrorMessage = "O campo CPF do cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O CPF do cliente deve ser númerico!")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "O CPF do cliente de ter 11 números!")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "O campo gênero do cliente é obrigatório")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "O campo CEP do cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O CEP do cliente deve ser númerico!")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "O CEP do cliente de ter 8 números!")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
            [StringLength(100, ErrorMessage = "O Logradouro pode ter no máximo 100 caracteres!")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "O campo Complemento é obrigatório")]
            [StringLength(100, ErrorMessage = "O Complemento pode ter no máximo 100 caracteres!")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "O campo Bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "O Bairro pode ter no máximo 100 caracteres!")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "O campo Cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "O Cidade pode ter no máximo 100 caracteres!")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "O campo Estado é obrigatório")]
            [StringLength(50, ErrorMessage = "O Estado pode ter no máximo 100 caracteres!")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "O campo Telefone do cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "O Telefone do cliente deve ser númerico!")]
            public string Telefone { get; set; }

            [StringLength(50, ErrorMessage = "O campo Profissao pode ter no máximo 100 caracteres!")]
            public string Profissao { get; set; }

            [Required(ErrorMessage = "O campo RendaFamiliar do cliente é obrigatório")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda familiar deve ser um valor positivo!")]
            public Double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomeDoPai == this.NomeDaMae)
                {
                    throw new Exception("Nome do pai e da mãe não podem ser iguais!");
                }

                if (!NaoTemPai)
                {
                    if (this.NomeDoPai == "")
                    {
                        throw new Exception("Quando nome do pai estiver vazio é necessário checar não tem pai!");
                    }
                }

                bool validaCpf = Cls_Uteis.Valida(this.Cpf);

                if (!validaCpf)
                {
                    throw new Exception("Cpf inválido");
                }


            }

        }

        public class List
        {
            public List<Single> ListSingle { get; set; }
        }
    }
}
