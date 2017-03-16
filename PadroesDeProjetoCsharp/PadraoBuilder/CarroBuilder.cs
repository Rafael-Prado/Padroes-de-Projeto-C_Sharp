
namespace PadraoBuilder
{
    public class CarroBuilder: VeiculoBuilder
    {
        public CarroBuilder()
        {
           _veiculo = new Veiculo("Carro Passeio");
        }

        public override void BuildMotor()
        {
            _veiculo["motor"] = "127 Cavalos";
            
            
        }

        public override void BuildPortas()
        {
            _veiculo["portas"] = "4 portas";
        }

        public override void BuildPneus()
        {
            _veiculo["pneus"] = "4 pneus";
        }
    }
}
