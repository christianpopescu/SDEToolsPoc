#ifndef TEXT_FILE_HELPER_H
#define TEXT_FILE_HELPER_H
#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <memory>

using namespace std;
class TextFileHelper{
	
public:
	static unique_ptr<TextFileHelper> createTextFileHelper(string fileName);
	TextFileHelper& WriteLine(string p_line);
	virtual ~TextFileHelper();
 
	TextFileHelper();
protected:
	std::fstream file;
	vector<string> fileContent;
};

#endif //TEXT_FILE_HELPER_H
