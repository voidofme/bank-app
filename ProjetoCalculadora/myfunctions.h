#pragma once
void searchArray(int ages[], int size)
{
	for (int i = 0; i < size; i++)
	{
		std::cout << ages[i] << std::endl;
	}
}

void menu(int tell)
{
	switch(tell)
	{
	case 1: 
		std::cout << "case 1";
		break;
	case 2: std::cout << "case 2";
		break;
	}
}