import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

export default function AddAppointment() {
  const [petType, setPetType] = useState("");
  const [petName, setPetName] = useState("");
  const [doctorName, setDoctorName] = useState("");
  const [date, setDate] = useState("");
  const [time, setTime] = useState("");
  const navigate = useNavigate();
  const loggedInUserId = localStorage.getItem("loggedInUserId");

  const handleSubmit = (e) => {
    e.preventDefault();
    const appointmentData = { petType, petName, doctorName, date, time, userId: loggedInUserId };
    fetch("http://localhost:3000/Appointments", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(appointmentData),
    })
      .then(() => {
        alert("Appointment added successfully");
        navigate("/appointment/table");
      })
      .catch((err) => console.log(err.message));
  };

  return (
    <div className="container">
      <h2>ADD NEW APPOINTMENT</h2>
      <form onSubmit={handleSubmit}>
        <label htmlFor="petType">Pet Type:</label>
        <input type="text" id="petType" required value={petType} onChange={(e) => setPetType(e.target.value)} />
        
        <label htmlFor="petName">Pet Name:</label>
        <input type="text" id="petName" required value={petName} onChange={(e) => setPetName(e.target.value)} />
        
        <label htmlFor="doctorName">Doctor Name:</label>
        <input type="text" id="doctorName" required value={doctorName} onChange={(e) => setDoctorName(e.target.value)} />
        
        <label htmlFor="date">Date:</label>
        <input type="date" id="date" required value={date} onChange={(e) => setDate(e.target.value)} />
        
        <label htmlFor="time">Time:</label>
        <input type="time" id="time" required value={time} onChange={(e) => setTime(e.target.value)} />
        
        <div>
          <button className="btn2 btn-save">Save</button>
          <Link to="/appointment/table" className="btn2 btn-back">Back</Link>
        </div>
      </form>
    </div>
  );
}
