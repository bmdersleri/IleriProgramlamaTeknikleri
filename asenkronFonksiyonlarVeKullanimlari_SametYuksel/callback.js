const todos= [
    {title: "Todo 1", description : "Asenkron Fonksiyonları Araştır"},
    {title: "Todo 2", description : "Slaytı Hazırla"},
    {title: "Todo 3", description : "Video Çekimini Yap"},
];

let todoListEl = document.getElementById("todoList")

function todoList(){
    setTimeout(() => {
        let todoItems = "";
        todos.forEach(item =>{
            todoItems += `
            <li>
                <b>${item.title}</b>
                <p>${item.description}</p>            
            </li>`;
        });
        todoListEl.innerHTML = todoItems;
    }, 1000);
}
function newTodo(todo, callback) {
    setTimeout(() => {
        todos.push(todo);
        callback();
    }, 2000);
}

newTodo({
    title: "Todo 4",
    description: "Video Düzenle"    
}, todoList);

