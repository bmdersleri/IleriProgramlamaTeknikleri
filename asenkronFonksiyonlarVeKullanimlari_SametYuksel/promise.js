const todos = [
    {title: "Todo 1", description : "Asenkron Fonksiyonları Araştır"},
    {title: "Todo 2", description : "Slaytı Hazırla"},
    {title: "Todo 3", description : "Video Çekimini Yap"},
];


let todoListEl = document.getElementById("todoList")

function todoList() {
    setTimeout(() => {
        let todoItems = "";
        todos.forEach(item => {
            todoItems += `
            <li>
                <b>${item.title}</b>
                <p>${item.description}</p>            
            </li>`;
        });
        todoListEl.innerHTML = todoItems;
    }, 1000);
}

function newTodo(todo) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            todos.push(todo);

            const e = false;
            if (!e) {
                resolve();
            }
            else {
                reject("Hata Var...");
            }
        }, 2000);
    });
}

newTodo({
    title: "Todo 4",
    description: "Video Düzenle"
})
    .then(response => {
        console.log("Yeni Liste", response);
        todoList();
    })
    .catch(e => {
        console.log(e);
    });
        
        
const p1 = Promise.resolve("P1");
const p2 = new Promise((resolve, reject) => {
    setTimeout(()=>{
        resolve("2. Promise");        
    },2000);
});

const p3 = 14021967;
const p4 = fetch("https://jsonplaceholder.typicode.com/posts").then(res =>res.json());

Promise.all([p1,p2,p3,p4]).then(promises =>{
    console.log("promises",promises);
});
