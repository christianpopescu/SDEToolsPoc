#include "ClassHelper.h"

ClassHelper::ClassHelper (std::string _class_name) {
   class_name = _class_name;
   pfileH = TextFileHelper::createTextFileHelper(class_name + ".h");
   pfileCpp = TextFileHelper::createTextFileHelper(class_name + ".cc");
}
void ClassHelper::generateAndSaveFiles() {
   generateH();
   saveH();
   generateCpp();
   saveCpp();
}

void ClassHelper::generateCpp(){
	(*pfileCpp).WriteLine("#include \"" + class_name + ".h\"");
}  

void ClassHelper::generateH() {
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

 void ClassHelper::saveCpp() {
	 (*pfileCpp).SaveFile();
 }  

 void ClassHelper::saveH() {
	 (*pfileH).SaveFile();
 }     

