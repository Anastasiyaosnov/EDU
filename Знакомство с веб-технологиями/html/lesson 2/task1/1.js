const user_value = Number.parseInt(prompt("Введите температуру в градусах Цельсия")).toFixed(2);
const total_value = ((user_value * 9/5) + 32).toFixed(2);
alert(`Цельсий: ${user_value}, Фаренгейт: ${total_value}`);