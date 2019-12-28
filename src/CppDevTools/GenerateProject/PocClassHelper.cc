#include <iostream>
#include <string>
#include <fstream>
#include "project/TextFileHelper.h"

class ClassHelper{
                private:
                ClassHelper();
				unique_ptr<TextFileHelper> pfileH;
				unique_ptr<TextFileHelper> pfileCpp;
                public:
                ClassHelper (std::string _class_name) {
                               class_name = _class_name;
							   pfileH = TextFileHelper::createTextFileHelper(class_name + ".h");
							   pfileCpp = TextFileHelper::createTextFileHelper(class_name + ".cc");
                }
                std::string class_name;
                std::string protectionH;
                
                void generateAndSaveFiles() {
                               generateH();
							   saveH();
                               generateCpp();
							   saveCpp();
                }

    void generateCpp(){
                    (*pfileCpp).WriteLine("#include \"" + class_name + ".h\"");
                }                              
	void generateH() {
				   if (protectionH.length() > 0){
						(*pfileH).WriteLine("#ifndef " + protectionH ).											   
								  WriteLine("#define " + protectionH );
				   }
				   (*pfileH).WriteLine("#include <iostream>" ).WriteLine("")
					   .WriteLine("class " + class_name + "{")
					   .WriteLine("")
					   .WriteLine("};");
				   if (protectionH.length() > 0){
							 (*pfileH).WriteLine("#endif //" + protectionH  );
				   }
				   
	}
	 void saveCpp() {
		 (*pfileCpp).SaveFile();
	 }               
	 void saveH() {
		 (*pfileH).SaveFile();
	 }               
                
};
int main() {

               ClassHelper ch ("TextFileHelper");
                ch.protectionH = "TEXT_FILE_HELPER_H";
                ch.generateAndSaveFiles();
}
