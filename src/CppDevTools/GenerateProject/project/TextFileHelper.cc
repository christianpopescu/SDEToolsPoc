#include "TextFileHelper.h"

unique_ptr<TextFileHelper> TextFileHelper::createTextFileHelper(string fileName){
	unique_ptr<TextFileHelper> tfh = make_unique<TextFileHelper>();
	tfh->file.open(fileName.c_str());
	return tfh;
}

TextFileHelper& TextFileHelper::WriteLine(string p_line){
	fileContent.push_back(p_line);
	return *this;
}

TextFileHelper::~TextFileHelper(){
	if (file.is_open()) file.close();
}

TextFileHelper::TextFileHelper(){
}