namespace GameTOP.Lib
{
    public class Jogador1 : iJogador
    {
    public readonly string _Nome;
    public Jogador1(string nome = "Ronaldo")

    {
        _Nome = nome;
    }
   
        string iJogador.Corre()
        {
            throw new System.NotImplementedException();
        }

        string iJogador.Passe()
        {
            throw new System.NotImplementedException();
        }

        string iJogador.Chuta()
        {
            throw new System.NotImplementedException();
        }
    }
    }