using Business;
using Entidades;

List<String> nombresJugadores = ["Nico", "Delia", "Rene"];

List<Jugador> jugadores = Juego.Iniciar(Baraja.BarajaGeneral, nombresJugadores);

Console.ReadLine();