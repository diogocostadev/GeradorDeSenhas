namespace GerenciadorDeSenhas;

public class Gerenciador
{

    public string GerarSenha(int tamanhoDaSenha, bool aceitaMaiusculas, bool aceitaNumeros, bool aceitaCaracteresEspeciais)
    {

        string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
        string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numeros = "0123456789";
        string caracteresEspeciais = "!@#$%¨&*()_+";

        string caracteres = letrasMinusculas;

        if (aceitaMaiusculas) caracteres += letrasMaiusculas;
        if (aceitaNumeros) caracteres += numeros;
        if (aceitaCaracteresEspeciais) caracteres += caracteresEspeciais;

        char[] senha = new char[tamanhoDaSenha];
        Random random = new Random();
        
        for (int i = 0; i < tamanhoDaSenha; i++)
        {
            senha[i] = caracteres[random.Next(0, caracteres.Length)];
        }
        
        return new string(senha);
    }

    public void SalvarSenha(string senha)
    {
        string nomeArquivo = "senhas.txt";
        using (StreamWriter escritor = File.AppendText(nomeArquivo))
        {
            escritor.WriteLine(senha);
        }
        Console.WriteLine("Senha salva com sucesso!");
    }

    public List<string> LerSenhas()
    { 
        string caminhoArquivo = "senhas.txt";
        if (File.Exists(caminhoArquivo))
        {
            return File.ReadAllLines(caminhoArquivo).ToList();
        }
        
        return new List<string>();
        
    }

}
