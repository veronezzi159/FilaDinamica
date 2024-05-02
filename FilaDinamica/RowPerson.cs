using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaDinamica
{
    internal class RowPerson
    {
        Person? head;
        Person? tail;
        int countPush;
        int countPop;

        public RowPerson()
        {
            head = null;
            tail = null;
            countPush = 0;
            countPop = 0;   
        }

        void pause ()
        {
            Console.WriteLine("Pressione qualquer tecla para continuar: ");
            Console.ReadKey();
        }

        bool isEmpty()
        {
            return head == null && tail == null;    
        }

        public void push(Person aux)
        {
            if (isEmpty() == true)
            {
                this.head = aux;
                this.tail = aux;
            }else
            {
                this.tail.setNext(aux);
                tail = aux;                
            }
            setCountPush();
            Console.WriteLine("Pessoa cadastrada com sucesso!");
            pause();
        }

        public void pop()
        {
            if (isEmpty() == true)
            {
                Console.WriteLine("Fila vazia! Impossivel Remoção");
                pause ();
            }
            else
            {
                if (this.tail == this.head)
                {
                    this.head = this.tail = null;

                }
                else
                {
                    this.head = this.head.getNext();
                }
                setCountPop();
                Console.WriteLine("Pessoa removida com sucesso!");
                pause();
            }
            
        }

        public void print()
        {
            Person? aux;            
            if (isEmpty())
            {
                Console.WriteLine("Fila vazia!");
                pause();
            }
            else
            {
                aux = this.head;
                do
                {
                    aux.printName();
                    aux = aux.getNext();

                } while (aux!= null);
                Console.WriteLine("Fim da impressão!");
            }
        }

        void setCountPush()
        {
            this.countPush += 1;
        }

        void setCountPop()
        {
            this.countPop += 1;
        }

        int getCountPush()
        {
            return this.countPush;  
        }

        int getCountPop()
        {
            return this.countPop;
        }

        int getSize()
        {
            return this.countPush - this.countPop;
        }

        public void printCountPush()
        {
            Console.WriteLine($"Número de entradas: {this.getCountPush()}");
        }

        public void printCountPop()
        {
            Console.WriteLine($"Número de saídas: {this.getCountPop}");
        }
        public void printSize()
        {            
            Console.WriteLine($"Número de pessoas na fila: {this.getSize()}");
        }

        public void searchPerson()
        {
            if ( isEmpty() )
            {
                Console.WriteLine("Fila vazia! Impossível buscar");
                pause();
            }
            else
            {
                Console.WriteLine("Digite o nome da pessoa que deseja buscar: ");
                int count = 0;
                string search = Console.ReadLine();
                Person current = head;
                bool sh;
                do
                {
                    sh = search.Equals(current.getName());
                    count++;
                    current = current.getNext();
                } while (current != null || sh == true);
                if (sh == true)
                {
                    Console.WriteLine($"A pessoa {search} esta na fila, na posição {count} de {this.getSize}");
                }
                else
                {
                    Console.WriteLine($"A pessoa {search} não aparece na fila!");
                }
                
            }
        }
    }
}
