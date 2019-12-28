#include "TextFileHelper.h"
template <typename T>

// Method extracted from abseil-cpp library    memory.h -file
std::unique_ptr<T> WrapUnique(T* ptr) {
  static_assert(!std::is_array<T>::value, "array types are unsupported");
  static_assert(std::is_object<T>::value, "non-object types are unsupported");
  return std::unique_ptr<T>(ptr);
}

// WrapUnique used to create unique pointer with protected constructor
unique_ptr<TextFileHelper> TextFileHelper::createTextFileHelper(string fileName){
	unique_ptr<TextFileHelper> tfh = WrapUnique(new TextFileHelper());
	tfh->file.open(fileName.c_str(), std::ios::out);
	return tfh;
}

TextFileHelper& TextFileHelper::WriteLine(string p_line){
	fileContent.push_back(p_line);
	return *this;
}
TextFileHelper& TextFileHelper::SaveFile(){
	for (auto s : fileContent)
		file << s << "\n";
	return *this;
}
TextFileHelper::~TextFileHelper(){
	if (file.is_open()) file.close();
}

TextFileHelper::TextFileHelper(){
}