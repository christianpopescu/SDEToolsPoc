#ifndef CLASS_HELPER_H
#define CLASS_HELPER_H
#include <iostream>
#include <memory>
#include "TextFileHelper.h"

using namespace std;
class ClassHelper{
	public:
	ClassHelper (std::string _class_name);
	std::string class_name;
	std::string protectionH;
	
	void generateAndSaveFiles(); 
    void generateCpp();                        
	void generateH();
	void saveCpp(); 
	void saveH();
	private:
	ClassHelper() = delete;
	unique_ptr<TextFileHelper> pfileH;
	unique_ptr<TextFileHelper> pfileCpp;

};
#endif //CLASS_HELPER_H
