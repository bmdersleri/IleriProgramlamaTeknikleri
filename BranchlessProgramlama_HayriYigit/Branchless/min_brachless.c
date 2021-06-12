#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int min(int x, int y) { 
  return y + ((x - y) & ((x - y) >> 31)); 
}

int main(int argc, char *argv[]) {
  srand(time(0));
  for (int i = 0; i < 1000000; i++) {
    int num_1 = rand() % 101;
    int num_2 = rand() % 101;
    min(num_1, num_2);
  }
  return 0;
}
