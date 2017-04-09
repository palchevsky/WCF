using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

/*
 * Задание №1
 * Создать клиент-серверное приложение «крестики-нолики».
 * Приложение должно предоставлять возможность играть клиентам
 * в «крестики-нолики» по сети. Серверная часть приложения
 * должна быть WCF-службой в виде dll библиотеки и позволять
 * создавать игру при подключении двух игроков. Следующие два
 * подключившихся клиента создадут свою игру и т.д.
 * Клиентская часть приложения должна быть создана как Windows
 * Forms или WPF приложение. Правила игры стандартные. Необходимо
 * реализовать игровой сеанс, состоящий из нескольких игр. Т.е.,
 * после завершения одной игры начинать следующую игру между
 * этими же двумя игроками. Надо запоминать и отображать текущий
 * счет, фиксировать выигрышные комбинации и т.п. Игровой сеанс
 * завершается, когда один из пары клиентов отключается от службы.
 */

namespace WS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new GameService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
