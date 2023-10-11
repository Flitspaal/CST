// LoterijPracticumVS2019.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#define _CRT_SECURE_NO_WARNINGS // Disable the warning for scanf
#include <iostream>

void OverflowInt() {
	int myInt = INT_MAX;  // Maximaal positieve waarde voor een int

	std::cout << "\nHuidige waarde van myInt: " << myInt << std::endl;

	myInt = myInt + 1;  // Probeer 1 toe te voegen aan de maximale waarde

	std::cout << "Nieuwe waarde van myInt na overflow: " << myInt << std::endl;
}

int main()
{
    //std::cout << "Hello World!\n";
	

	char alfabet[27] = { "abcdefghijklmnopqrstuvwxyz" };
	char winnende_nummers[3][9] = {
		{"87654321"}, {"11112222"},{"99990000"}
	};
	unsigned int Uint = -10;
	signed int Sint = -10;
	
	printf("Voer je lotnummmer in (max 8)");
	char line[9];	// room for 8 chars + '\0'
	//char line2[10]; // room for 9 + '\0'
	scanf("%s", line); // inlezen
	printf("Je hebt ingevoerd: %s\n", line); // print
	printf("Uint = %i en Sint = %i", Uint, Sint);
	int gewonnen = false;
	int number_of_elements = sizeof	(winnende_nummers) / sizeof(winnende_nummers[0]);
	for (int i = 0; i < number_of_elements; i++) {
		if (strncmp(line, winnende_nummers[i], 8) == 0) {
			gewonnen = true;
		}
	}

	int controle = strlen(winnende_nummers[1]);

	if (gewonnen && controle == 8) {
		printf("Je hebt gewonnen met je nummer: %s\n", line);
	}
	OverflowInt();

	char buff2[10] = { "     " };
	printf("\nEnter text to exit");
	scanf("%s", buff2);
	return 0;
}


// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file


