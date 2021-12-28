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

vector<vector<String^>>^ PocExcel::GetTableFromFirstSheet(String^ workbook)
{
	vector<vector<String^>>^ result = gcnew vector<vector<String^>>();
	Excel::Application^ app = gcnew Excel::ApplicationClass();
	Workbooks^ wrkbk = app->Workbooks;
	wrkbk->Open(workbook, Type::Missing, Type::Missing, Type::Missing, Type::Missing,
		Type::Missing, Type::Missing, Type::Missing, Type::Missing, Type::Missing, Type::Missing,
		Type::Missing, Type::Missing, Type::Missing, Type::Missing);
	Worksheet^ wrksheet = static_cast<Worksheet^>(wrkbk[1]->Worksheets[1]);
	Range^ range = wrksheet->Cells->Find("*", System::Reflection::Missing::Value,
		System::Reflection::Missing::Value, System::Reflection::Missing::Value,
		Excel::XlSearchOrder::xlByRows, Excel::XlSearchDirection::xlPrevious,
		false, System::Reflection::Missing::Value, System::Reflection::Missing::Value).Row;
	wrkbk->Close();
	app->Quit();
	return result;
}
