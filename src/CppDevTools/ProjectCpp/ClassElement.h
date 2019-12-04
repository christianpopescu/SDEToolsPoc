#include <string>
class ClassElement {
 public:
  ClassElement() = delete;
  ClassElement(std::string p_name);
  std::string getHeaderFileName() const;
  std::string getCppFileName() const;
  std::string createHeaderFile() const;
  std::string createCodeFile() const;
 private:
  std::string name;
};
