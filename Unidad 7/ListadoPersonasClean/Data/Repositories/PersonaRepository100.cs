using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class RepoPersonas : IGetListaPersonas
    {
        public Persona[] getListaPersonas()
        {
            return [
                new Persona(1, "Elena", "Alcalde Garc�a"),
                new Persona(2, "Luis", "Cerrato Vela"),
                new Persona(3, "Mar�a", "D�az Fern�ndez"),
                new Persona(4, "Javier", "G�mez P�rez"),
                new Persona(5, "Laura", "Mart�nez L�pez"),
                new Persona(6, "Carlos", "S�nchez Ruiz"),
                new Persona(7, "Ana", "Romero Torres"),
                new Persona(8, "Miguel", "Navarro D�az"),
                new Persona(9, "Luc�a", "Hern�ndez Rojas"),
                new Persona(10, "David", "Castro Medina"),
                new Persona(11, "Sof�a", "Moreno Garc�a"),
                new Persona(12, "Andr�s", "L�pez Salazar"),
                new Persona(13, "Valeria", "N��ez Cabrera"),
                new Persona(14, "Tom�s", "Blanco Romero"),
                new Persona(15, "Paula", "Paredes Le�n"),
                new Persona(16, "Ignacio", "Ruiz Herrera"),
                new Persona(17, "Daniela", "Santos Molina"),
                new Persona(18, "Hugo", "Delgado Cruz"),
                new Persona(19, "Martina", "Campos Su�rez"),
                new Persona(20, "Emilio", "Fern�ndez Bravo"),
                new Persona(21, "Julia", "Mar�n Ortega"),
                new Persona(22, "Rub�n", "Pe�a Sol�s"),
                new Persona(23, "Alicia", "Cano Fuentes"),
                new Persona(24, "Santiago", "Gim�nez Rivas"),
                new Persona(25, "Clara", "Aguilar Vega"),
                new Persona(26, "Joaqu�n", "Ortiz M�ndez"),
                new Persona(27, "Natalia", "Carrasco Nieto"),
                new Persona(28, "Marco", "Gallardo Rubio"),
                new Persona(29, "Noa", "Serrano Cordero"),
                new Persona(30, "�lvaro", "Esteban Dom�nguez"),
                new Persona(31, "Irene", "Ramos Gil"),
                new Persona(32, "Mario", "Silva Arias"),
                new Persona(33, "Lola", "Mora Lozano"),
                new Persona(34, "Bruno", "Vargas D�vila"),
                new Persona(35, "Adriana", "Reyes Pascual"),
                new Persona(36, "Cristian", "Cuenca Pons"),
                new Persona(37, "Eva", "Bueno Peralta"),
                new Persona(38, "Samuel", "Rold�n Bernal"),
                new Persona(39, "Gabriela", "Camacho Salas"),
                new Persona(40, "Esteban", "Ben�tez Torres"),
                new Persona(41, "In�s", "Soto Calder�n"),
                new Persona(42, "Fernando", "Iglesias Rosas"),
                new Persona(43, "Victoria", "Aranda L�zaro"),
                new Persona(44, "Rodrigo", "Gallego Morillo"),
                new Persona(45, "Carmen", "Solano Ferrer"),
                new Persona(46, "Gonzalo", "Alonso Vidal"),
                new Persona(47, "Elisa", "Martos Casado"),
                new Persona(48, "�scar", "Del Valle Cuesta"),
                new Persona(49, "Nerea", "Garrido Lozano"),
                new Persona(50, "Lucas", "Casta�o Arenas"),
                new Persona(51, "�ngela", "Prado Guzm�n"),
                new Persona(52, "Mateo", "Redondo Pastor"),
                new Persona(53, "Claudia", "Rom�n Sevilla"),
                new Persona(54, "Alonso", "Del R�o Salmer�n"),
                new Persona(55, "Beatriz", "Navarrete Gal�n"),
                new Persona(56, "Juli�n", "Villar Paredes"),
                new Persona(57, "Lorena", "S�ez Aguado"),
                new Persona(58, "Iv�n", "Crespo Hidalgo"),
                new Persona(59, "Teresa", "Vallejo Redondo"),
                new Persona(60, "Marcos", "Cabrera Montoro"),
                ];
        }
    }
}
