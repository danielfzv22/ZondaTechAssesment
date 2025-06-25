import { useEffect, useState } from "react";
import ProductTable from "./ProductsTable";
import { Box, Button, Stack, Typography } from "@mui/material";
import ProductModalForm from "./ProductModalForm";

export default function ProductsDetailsTab({ customerId }) {
  const [products, setProducts] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  const [productToEdit, setProductToEdit] = useState(null);
  const [showModal, setShowModal] = useState(false);
  const [errorMessage, setErrorMessage] = useState("");

  useEffect(() => {
    if (!customerId) return;

    const fetchProducts = async () => {
      setIsLoading(true);
      try {
        const res = await fetch(
          `http://localhost:5255/api/customers/${customerId}/products`
        );
        const data = await res.json();
        if (data.success) {
          setProducts(data.data);
        }
      } catch (err) {
        console.error("Error fetching products:", err);
      } finally {
        setIsLoading(false);
      }
    };

    fetchProducts();
  }, [customerId]);

  const handleEdit = (product) => {
    setProductToEdit(product);
    setShowModal(true);
  };

  const handleDelete = async (id) => {
    const confirm = window.confirm(
      "Are you sure you want to delete this product?"
    );
    if (!confirm) return;

    const response = await fetch(`http://localhost:5255/api/products/${id}`, {
      method: "DELETE",
    });

    if (response.ok) {
      setProducts((prev) => prev.filter((p) => p.id !== id));
    }
  };

  const handleAdd = async () => {
    setProductToEdit({ name: "", price: 0 });
    setShowModal(true);
  };

  const handleSave = async (product) => {
    if (!customerId) return;

    if (!product.name.trim()) {
      throw new Error("product name is required");
    }

    product = { ...product, customerId: customerId };
    const isNew = !product.id;
    const method = isNew ? "POST" : "PUT";
    const url = isNew
      ? `http://localhost:5255/api/products`
      : `http://localhost:5255/api/products/${product.id}`;

    try {
      const response = await fetch(url, {
        method,
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(product),
      });

      const responseData = await response.json();

      if (!responseData.success) {
        setErrorMessage(responseData.message);
        return;
      }

      const resProduct = responseData.data;
      if (isNew) {
        setProducts((prev) => [...prev, resProduct]);
      } else {
        setProducts((prev) =>
          prev.map((p) => (p.id === resProduct.id ? resProduct : p))
        );
      }

      setErrorMessage("");
      setShowModal(false);
    } catch (error) {
      setErrorMessage(error.message);
    }
  };

  return (
    <Stack>
      <Box display={"flex"} justifyContent={"space-between"}>
        <Typography>Products {`(${products.length})`}</Typography>
        <Button variant="contained" onClick={handleAdd}>
          Add Product
        </Button>
      </Box>
      <ProductTable
        products={products}
        isLoading={isLoading}
        onDelete={handleDelete}
        onEdit={handleEdit}
      />

      <ProductModalForm
        open={showModal}
        product={productToEdit}
        onClose={() => {
          setErrorMessage("");
          setShowModal(false);
        }}
        onSave={handleSave}
        errorMessage={errorMessage}
      />
    </Stack>
  );
}
