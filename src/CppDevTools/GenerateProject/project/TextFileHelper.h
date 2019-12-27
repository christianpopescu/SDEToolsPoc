#ifndef TEXT_FILE_HELPER_H
#define TEXT_FILE_HELPER_H
#include <iostream>
#include <string>
#include <vector>

class TextFileHelper{
	using namespace std;
public:
	TextFileHelper& createTextFileHelper(string fileName);
	TextFileHelper& WriteLine(string p_line);
protected: 
	TextFileHelper();
	std::fstream file;
	vector<string> fileContent;
};
#endif //TEXT_FILE_HELPER_H
