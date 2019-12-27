#include <iostream>
#include <string>
#include <fstream>

class ClassHelper{
                private:
                ClassHelper();
                public:
                ClassHelper (std::string _class_name) {
                               class_name = _class_name;
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
                               std::fstream hFile;
                               hFile.open((class_name + ".h").c_str(), std::ios::out);
                               if (protectionH.length() > 0){
                                               hFile << "#ifndef " + protectionH << "\n";           
                                               hFile << "#define " + protectionH << "\n";          
                               }
                                               
                               hFile << "#include <iostream>" << "\n";
                               hFile << "\n";
                               hFile << "class " + class_name + "{" + "\n";
                               hFile << "\n";
                               hFile << "};" << "\n";
                               
                               if (protectionH.length() > 0){
                                               hFile << "#endif //" + protectionH << "\n";        
                               }

                               hFile.close();
                }
                
                
};
int main() {

               ClassHelper ch ("TextFileHelper");
                ch.protectionH = "TEXT_FILE_HELPER_H";
                ch.generateFiles();
}
