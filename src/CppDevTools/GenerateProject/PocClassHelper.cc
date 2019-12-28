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
                
                void generateFiles() {
                               generateH();
                               generateCpp();
                }

    void generateCpp(){
                               std::fstream cppFile;
                               cppFile.open((class_name + ".cpp").c_str(), std::ios::out);
                               cppFile << "#include \"" << class_name + ".h\"";
                               cppFile.close();
                }                              
                void generateH() {
					
					
//                               std::fstream hFile;
//                               hFile.open((class_name + ".h").c_str(), std::ios::out);
                               if (protectionH.length() > 0){
//                                               hFile << "#ifndef " + protectionH << "\n";           
//                                               hFile << "#define " + protectionH << "\n";  
									(*pfileH).WriteLine("#ifndef " + protectionH ).											   
											  WriteLine("#define " + protectionH );
                               }
                               (*pfileH).WriteLine("#include <iostream>" ).WriteLine("")
								   .WriteLine("class " + class_name + "{")
								   .WriteLine("")
								   .WriteLine("};");
							           
/*                               hFile << "#include <iostream>" << "\n";
                               hFile << "\n";
                               hFile << "class " + class_name + "{" + "\n";
                               hFile << "\n";
                               hFile << "};" << "\n";
  */                             
                               if (protectionH.length() > 0){
//                                               hFile << "#endif //" + protectionH << "\n";    
										 (*pfileH).WriteLine("#endif //" + protectionH  );
                               }

 //                              hFile.close();
							   (*pfileH).SaveFile();
                }
                
                
};
int main() {

               ClassHelper ch ("TextFileHelper");
                ch.protectionH = "TEXT_FILE_HELPER_H";
                ch.generateFiles();
}
