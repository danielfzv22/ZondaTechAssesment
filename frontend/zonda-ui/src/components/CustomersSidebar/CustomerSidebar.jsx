import {
  Box,
  Button,
  FormControl,
  InputLabel,
  MenuItem,
  Select,
  Tab,
  Tabs,
  Typography,
} from "@mui/material";

export default function CustomerSidebar({
  customers,
  onCustomerSelected,
  selectedCustomerId,
  tabIndex,
  onTabChange,
}) {
  const handleChange = (event) => {
    const id = event.target.value;
    onCustomerSelected(id);
  };

  return (
    <Box width="250px" p={2} display="flex" flexDirection="column" gap={2}>
      <Typography color="primary" variant={"h5"}>
        Customers
      </Typography>
      <FormControl fullWidth>
        <InputLabel variant="standard">Select Customer</InputLabel>
        <Select
          value={selectedCustomerId}
          label="customer"
          onChange={handleChange}
        >
          {customers.map((cus) => (
            <MenuItem key={cus.id} value={cus.id}>
              {cus.name}
            </MenuItem>
          ))}
        </Select>
      </FormControl>

      <Tabs
        orientation="vertical"
        value={tabIndex}
        onChange={(_, newIndex) => onTabChange(newIndex)}
        sx={{ mt: 2 }}
      >
        <Tab label="Customer Info" />
        <Tab label="Product Details" />
      </Tabs>
    </Box>
  );
}
