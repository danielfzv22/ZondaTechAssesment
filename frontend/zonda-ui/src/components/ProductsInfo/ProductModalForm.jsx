import {
  Dialog,
  DialogTitle,
  DialogContent,
  DialogActions,
  TextField,
  Button,
} from "@mui/material";
import { useState, useEffect } from "react";

export default function ProductModalForm({
  open,
  product,
  onClose,
  onSave,
  errorMessage,
}) {
  const [form, setForm] = useState({ name: "", price: 0 });

  useEffect(() => {
    if (product) {
      setForm({ name: product.name, price: product.price });
    }
  }, [product]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setForm((prev) => ({
      ...prev,
      [name]: name === "price" ? parseFloat(value) : value,
    }));
  };

  const handleSubmit = () => {
    if (form.name.trim() === "") return;
    onSave({ ...product, ...form });
  };

  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>Product</DialogTitle>
      <DialogContent>
        <TextField
          margin="dense"
          name="name"
          label="Product Name"
          fullWidth
          value={form.name}
          onChange={handleChange}
          error={!!errorMessage}
          helperText={errorMessage || " "}
        />
        <TextField
          margin="dense"
          name="price"
          label="Price"
          type="number"
          fullWidth
          value={form.price}
          onChange={handleChange}
        />
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Cancel</Button>
        <Button variant="contained" onClick={handleSubmit}>
          Save
        </Button>
      </DialogActions>
    </Dialog>
  );
}
