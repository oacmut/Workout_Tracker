        document.getElementById("listButton").addEventListener("click", () => {
            fetch("api/values")
                .then(response => response.json())
                .then(data => {
                    const tableBody = document.getElementById("nutritionTable").querySelector("tbody");
                    tableBody.innerHTML = "";
                    data.forEach(item => {
                        const row = document.createElement("tr");
                        row.innerHTML = `
                                    <td>${item.nutritionId}</td>
                                    <td>${item.personId}</td>
                                    <td>${item.date}</td>
                                    <td>${item.mealType}</td>
                                    <td>${item.calories}</td>
                                    <td>${item.notes}</td>
                                    <td><button onclick="deleteEntry(${item.nutritionId})">Törlés</button></td>
                                `;
                        tableBody.appendChild(row);
                    });
                });
        });

        document.getElementById("addButton").addEventListener("click", () => {
            const data = {
                PersonId: parseInt(document.getElementById("personId").value),
                Date: document.getElementById("date").value,
                MealType: document.getElementById("mealType").value,
                Calories: parseInt(document.getElementById("calories").value),
                Notes: document.getElementById("notes").value || null
            };

            fetch("api/values", {
                method: "POST",
                headers: { "Content-Type": "application/json" },
                body: JSON.stringify(data)
            }).then(() => {
                document.getElementById("listButton").click();
            });
        });

        function deleteEntry(id) {
            fetch(`api/values/${id}`, { method: "DELETE" })
                .then(() => {
                    document.getElementById("listButton").click();
                });
        }