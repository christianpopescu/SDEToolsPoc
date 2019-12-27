#include "TextFileHelper.h"

TextFileHelper& TextFileHelper::createTextFileHelper(string fileName);{
	TextFileHelper tfh;
	tfh.open(fileName.c_str());
	return tfh;
}

TextFileHelper& TextFileHelper::WriteLine(string p_line){
	fileContent.push_back(p_line);
	return *this;
}

TextFileHelper::~TextFileHelper(){
	if (tfh.is_open()) tfh.close();
}