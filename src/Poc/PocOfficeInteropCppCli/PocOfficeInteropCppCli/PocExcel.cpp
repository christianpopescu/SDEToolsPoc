#include "pch.h"
#include "PocExcel.h"
#include <msclr\marshal_cppstd.h>

#include <iostream>

using namespace System;
using namespace Microsoft::Office::Interop::Excel;

#define Excel   Microsoft::Office::Interop::Excel

void PocExcel::ShowExcelSheetName()
{
	Excel::Application^ app = gcnew Excel::ApplicationClass();
	Workbooks^ wrkbk = app->Workbooks;
	wrkbk->Open("E:\\Temp\\TestWorkbook.xlsx", Type::Missing, Type::Missing, Type::Missing, Type::Missing,
		Type::Missing, Type::Missing, Type::Missing, Type::Missing, Type::Missing, Type::Missing,
		Type::Missing, Type::Missing, Type::Missing, Type::Missing);
	std::cout << msclr::interop::marshal_as<std::string>((wrkbk[1]->Name)) << std::endl;
	std::cout << msclr::interop::marshal_as<std::string>((static_cast<Worksheet^>(wrkbk[1]->Worksheets[1])->Name)) << std::endl;
	wrkbk->Close();
	app->Quit();
}
