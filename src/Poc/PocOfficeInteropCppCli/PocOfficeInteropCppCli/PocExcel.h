#pragma once
#include <msclr\marshal_cppstd.h>
#include <cliext/vector>

using namespace System;
using namespace cliext;
using namespace System::Collections::Generic;
ref class PocExcel
{
public:
	static void ShowExcelSheetName();
	static  IEnumerable<String^>^ GetTableFromFirstSheet(String^ workbook);
};

