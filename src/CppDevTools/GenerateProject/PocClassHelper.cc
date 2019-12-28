#include <iostream>
#include <string>
#include <fstream>
#include "project/TextFileHelper.h"
#include "project/ClassHelper.h"

int main() {

               ClassHelper ch ("ClassHelper");
                ch.protectionH = "CLASS_HELPER_H";
                ch.generateAndSaveFiles();
}
