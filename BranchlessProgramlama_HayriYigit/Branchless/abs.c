#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int abs(int a) {
  if (a >= 0)
    return a;
  else
    return -a;
}

int main(int argc, char *argv[]) {
  for (int i = 0; i < 10000; i++) {
    int randomNum = rand() % 19 + (-9);
    abs(randomNum);
  }
  return 0;
}
