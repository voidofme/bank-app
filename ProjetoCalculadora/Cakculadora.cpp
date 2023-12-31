#include <iostream>

int main()
{
	double num1, num2, result;
	char oper;

	do
	{
		std::cout << "Enter number: ";
		std::cin >> num1;
		std::cout << "Enter operator: ";
		std::cin >> oper;
		std::cout << "Enter number: ";
		std::cin >> num2;

		switch (oper)
		{
		case '+':
			result = num1 + num2;
			std::cout << num1 << " + " << num2 << " = " << result << "\n";
			break;
		case '-':
			result = num1 - num2;
			std::cout << num1 << " - " << num2 << " = " << result << "\n";
			break;
		case '*':
			result = num1 * num2;
			std::cout << num1 << " x " << num2 << " = " << result << "\n";
			break;
		case '/':
			result = num1 / num2;
			std::cout << num1 << " ÷ " << num2 << " = " << result << "\n";
			break;

		default:
			std::cout << "Invalid operator!" << "\n";
		}
		system("PAUSE");
			system("CLS");

	} while (true);
	
	system("PAUSE");

}