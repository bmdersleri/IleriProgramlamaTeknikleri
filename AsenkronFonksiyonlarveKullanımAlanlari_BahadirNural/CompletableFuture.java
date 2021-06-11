private List<String> fetchFromDatabase(){
    Thread.sleep(5000); (1)
}

private List<byte[]> readFiles(){
    Thread.sleep(3000); (2)
}


CompletableFuture<Void> futred1 = CompletableFuture.runAsync(() -> {

    fetchFromDatabase(); (1);
});

CompletableFuture<Void> futured2 = CompletableFuture.runAsync(() ->{
    saveToFile(); (2)
});

futured1.join(); (3)
futured2.join(); (4)