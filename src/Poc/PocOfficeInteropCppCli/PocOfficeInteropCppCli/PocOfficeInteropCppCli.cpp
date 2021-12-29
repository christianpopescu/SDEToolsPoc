#include "pch.h"

#include <iostream>

#include "PocExcel.h"
#include "PocOutllook.h"

using namespace System;

int main(array<System::String ^> ^args)
{
	std::cout << "Choose option to run (1- Excel, 2-Outlook)";
	char c;
	std::cin >> c;
	switch (c) {
	case '1':
	{
		PocExcel::ShowExcelSheetName();
		IEnumerable<String^>^ v = PocExcel::GetTableFromFirstSheet("D:\\Temp\\TestWorkbook1.xlsx");
		for each (auto x in v)
		{
			System::Console::WriteLine(x);
		}
	}
		break;
	case '2':
		PocOutllook::ShowFolderList();
		break;
	}
	
	return 0;
}
