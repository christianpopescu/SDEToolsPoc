GTEST_CFLAGS = `pkg-config --cflags gtest_main`
GTEST_LIBS = `pkg-config --libs gtest_main`
TEST_DIR=test/
PROJECT_DIR=project/
headers:=$(PROJECT_DIR)TextFileHelper.h 
sources:=$(PROJECT_DIR)TextFileHelper.cc 
objects:=TextFileHelper.o 
mainexe=PocClassHelper.exe
mainobj=PocClassHelper.o
mainsrc=PocClassHelper.cc

.PHONY: clean tests all

run : main	
	./$(mainexe)

main : $(mainobj) $(objects)
	g++ -std=c++17 $(mainobj) $(objects) -o $(mainexe)

$(mainobj) : $(mainsrc)  $(sources) $(headers)
	g++ -std=c++17 -c $(mainsrc) $(sources)
clean :
	rm -f *.exe
	rm -f *.o
	rm -f *~
	rm -f $(PROJECT_DIR)/*~

