import { useEffect, useState } from "react";
import { Box, Typography } from "@mui/material";
import "./App.css";
import CustomerSidebar from "./components/CustomersSidebar/CustomerSidebar";
import ProductsDetailsTab from "./components/ProductsInfo/ProductsTab";
import CustomerTab from "./components/CustomerInfoTab/CustomerTab";

function App() {
  const [customers, setCustomers] = useState([]);
  const [selectedCustomerId, setSelectedCustomerId] = useState("");
  const [tabIndex, setTabIndex] = useState(0);

  const selectedCustomer = customers.find((c) => c.id === selectedCustomerId);

  useEffect(() => {
    const fetchCustomers = async () => {
      try {
        const res = await fetch("http://localhost:5255/api/customers");
        const data = await res.json();
        if (data.success) {
          setCustomers(data.data);
        }
      } catch (err) {
        console.error("Error fetching customers:", err);
      }
    };

    fetchCustomers();
  }, []);

  return (
    <Box display="flex" minHeight="100vh">
      <CustomerSidebar
        customers={customers}
        onCustomerSelected={setSelectedCustomerId}
        selectedCustomerId={selectedCustomerId}
        tabIndex={tabIndex}
        onTabChange={setTabIndex}
      />
      <Box flex={1} p={3}>
        {!selectedCustomerId ? (
          <Typography>Select a customer to view details</Typography>
        ) : tabIndex === 0 ? (
          <CustomerTab customer={selectedCustomer} />
        ) : (
          <ProductsDetailsTab customerId={selectedCustomerId} />
        )}
      </Box>
    </Box>
  );
}

export default App;
