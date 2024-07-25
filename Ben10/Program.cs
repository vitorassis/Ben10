using Ben10.Classes;
using Ben10.Classes.Aliens;

Omnitrix omnitrix = new Omnitrix();

void Mensagem(string alien)
{
    Console.WriteLine("Transformado no " +alien);
}

omnitrix.Transformar(omnitrix.GetAlienIndex(new XLR8()));
Mensagem(omnitrix.SelectedAlien.ToString());

omnitrix.Transformar(omnitrix.GetAlienIndex(new Besta()));
Mensagem(omnitrix.SelectedAlien.ToString());

omnitrix.Destransformar();