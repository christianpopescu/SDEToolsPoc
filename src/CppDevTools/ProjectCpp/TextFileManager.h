#include <string>
class TextFileManager {
 public : 
  TextFileManager() = delete;
  TextFileManager(std::string p_name);
  void WriteLine(std::string p_line);
 private :
  std::string name;
}
