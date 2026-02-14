Question 5: NotifyHub – Concurrent Notification Processing System (On Multithreading, Async Programming, Collections, OOP – Basic & Advanced, Annotations)
Scenario NotifyHub is a service used by an application to send notifications (email, SMS, app alerts) to users.
Notifications are generated continuously and must be:
• Processed quickly
• Sent using different delivery mechanisms
• Handled safely when multiple notifications are processed at the same time
The system must remain responsive even when the number of notifications increases significantly.


Problem Statement Design and implement a concurrent notification processing system using multithreading, asynchronous programming, and object-oriented design principles to manage notification intake, prioritization, and delivery.


Requirements
1️⃣ Notification Representation Each notification contains:
• Notification ID
• Recipient
• Message
• Priority
• Created Time
Different notification types require different sending behavior.
Rules apply to notification data:
• Notification ID must always be present
• Recipient must follow a predefined format
• Priority must fall within allowed values
These rules must be declared with the notification itself, not enforced repeatedly in logic.


2️⃣ Notification Intake When a notification is received:
• It must be added to an in-memory holding area
• Invalid notifications must be rejected with a clear reason
• Rejection of one notification must not affect others
The system must efficiently handle a growing number of notifications.


3️⃣ Concurrent Processing Notifications must be processed such that:
• Sending does not block intake of new notifications
• Multiple notifications can be sent at the same time
• Failure in sending one notification does not stop others


4️⃣ Processing Behavior The system must:
• Select sending logic dynamically based on notification type
• Ensure higher-priority notifications are processed first
• Safely update notification status after sending


5️⃣ Failure Handling Failures may occur due to:
• Invalid notification data
• Temporary sending failure
• Unexpected runtime issues
In all cases:
• The failure must be captured
• Notification status must reflect the failure
• Other notifications must continue processing


6️⃣ Design Constraints The solution must:
• Clearly separate notification data, sending logic, and processing coordination
• Avoid hard-coded dependencies
• Allow new notification types to be added with minimal changes


Concepts to be Used • OOPs Principles (Basic & Advanced)
• Collections Framework
• Multithreading
• Asynchronous Programming (async/await, tasks)
• Annotations / Attributes
• Exception Handling
• Concurrency & Synchronization
