import { useEffect, useState } from "react";
import { Link, useNavigate } from "react-router-dom";

export default function AppointmentTable() {
  const [appointments, setAppointments] = useState([]);
  const navigate = useNavigate();
  const loggedInUserId = localStorage.getItem("loggedInUserId");

  useEffect(() => {
    fetch(`http://localhost:3000/Appointments?userId=${loggedInUserId}`)
      .then((res) => res.json())
      .then((data) => setAppointments(data))
      .catch((err) => console.log(err.message));
  }, [loggedInUserId]);

  const editDetails = (id) => {
    navigate("/edit/appointment/" + id);
  };

  const deleteAppointment = (id) => {
    if (window.confirm("Are you sure you want to delete?")) {
      fetch("http://localhost:3000/Appointments/" + id, { method: "DELETE" })
        .then(() => {
          alert("Removed appointment successfully");
          setAppointments(appointments.filter((appt) => appt.id !== id));
        })
        .catch((err) => console.log(err.message));
    }
  };

  return (
    <div className="container">
      <h2>Appointment Records</h2>
      <div className="table-container">
        <Link to="/create/appointment" className="btn2 btn-add">ADD NEW APPOINTMENT</Link>
        <table>
          <thead>
            <tr>
              <th>Pet Type</th>
              <th>Pet Name</th>
              <th>Doctor Name</th>
              <th>Date</th>
              <th>Time</th>
              <th>Actions</th>
            </tr>
          </thead>
          <tbody>
            {appointments &&
              appointments.map((appt) => (
                <tr key={appt.id}>
                  <td>{appt.petType}</td>
                  <td>{appt.petName}</td>
                  <td>{appt.doctorName}</td>
                  <td>{appt.date}</td>
                  <td>{appt.time}</td>
                  <td>
                    <button onClick={() => editDetails(appt.id)} className="btn2 btn-primary">Edit</button>
                    <button onClick={() => deleteAppointment(appt.id)} className="btn2 btn-danger">Delete</button>
                  </td>
                </tr>
              ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}
