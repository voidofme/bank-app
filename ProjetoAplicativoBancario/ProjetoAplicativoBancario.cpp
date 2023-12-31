//Criar aplicativo banc�rio com op��o de saldo, saque e dep�sito.
#include <iostream>
#include <string>

//declarando uma classe com as vari�veis.
class var
{
public:
    std::string user = "mike";
    long long password = 123456;
    float balance = 0.0;
    float deposit = 0.0;
    float withdraw = 0.0;
    char choice;
    int option = 0;
};

//declarando a fun��o do menu
void bankMenu();

int main()
{
    //declarando uma instancia da classe var para que elas funcionem na fun��o main
    var var;

    //abrindo o menu no console
    bankMenu();
    
    //Oferecendo a op��o para o usu�rio fazer sua escolha no menu
    std::cin >> var.option;

    //O switch deixa o menu funcional, levando o usu�rio para as op��es que ele deseja.
    switch(var.option)
    {
        case 1:
            std::cout << "Your current balance is: " << var.balance << "\n";
                break;
        case 2:
            std::cout << "Enter value to deposit: ";
            std::cin >> var.deposit;
            std::cout << "You've successfully made a deposit, check your balance.\n";
            var.balance = + var.deposit;
            std::cout << "\n";
            std::cout << "Your current balance is: " << var.balance << "\n";

            break;
        case 3:
            std::cout << "Enter value to withdraw: ";
            std::cin >> var.withdraw;


    }

    system("PAUSE");
}

void bankMenu()
{
    std::cout << "****************************************************\n";
    std::cout << "****************** Banco LC ************************\n";
    std::cout << "****************************************************\n";
    std::cout << "\n";
    std::cout << "Choose an option below:\n";
    std::cout << "1. Balance\n";
    std::cout << "2. Deposit\n";
    std::cout << "3. Withdraw\n";
    std::cout << "4. Exit\n";
    std::cout << "\n";
}