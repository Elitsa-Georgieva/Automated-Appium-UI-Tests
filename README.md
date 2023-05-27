# Automated-Appium-UI-Tests
"Task Board" is a simple information system for managing tasks in a task board. Each task consists of title + description. Tasks are organized in boards, which are displayed as columns (sections): Open, In Progress, Done. Users can view the task board with the tasks, search for tasks by keyword, view task details, create new tasks and edit existing tasks (and move existing tasks from one board to another).

Appium-based automated mobile UI tests for the "TaskBoard" Android mobile app:

Assert the name of the first task
•	Open the app.
•	Connect to your backend API service. The default URL address is https://taskboard.nakov.repl.co/api, you have to change it to yours, that is part of the task /for example: http://{yoursite}/api
•	Search for the word "project".
•	Assert the first listed tasks has title "Project skeleton".
•	Close the app.
You are free to implement and run the tests in a local instance of Appium with Android Emulator or physical Android device.

